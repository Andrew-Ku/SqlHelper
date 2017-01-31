using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace XrmTaskHelperWpf
{
    public static class AutoMapperConfig
    {
        public static void ConfigureAndRun()
        {
            var profiles = new List<Profile>();
            var profilesAssembly = typeof(Services.MapProfiles.XrmTaskProfile).Assembly;

            profiles.AddRange(GetProfiles(profilesAssembly));
           
            Mapper.Initialize(a => profiles.ForEach(a.AddProfile));
        }

        private static IEnumerable<Profile> GetProfiles(Assembly profilesAssembly)
        {
            var profileType = typeof(Profile);

            try
            {
                return profilesAssembly.GetTypes()
                .Where(t => profileType.IsAssignableFrom(t) && t.GetConstructor(Type.EmptyTypes) != null)
                .Select(Activator.CreateInstance)
                .Cast<Profile>();
            }
            catch (ReflectionTypeLoadException ex)
            {

                throw new Exception(string.Join("<br/>", ex.LoaderExceptions.Select(e => e.Message)));
            }

        }
    }
}
