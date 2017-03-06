using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmTaskHelper.Core.Interfaces;

namespace XrmTaskHelper.Domain.Entities
{
    [Description("Эдементы задачи")]
    public class XrmTaskItem : IEntity
    {
        private List<int> _tagIds;
        private string _tagIdsStore;


        public int Id { get; set; }

        public int TaskId { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        [DisplayName("Заметка")]
        public string Note { get; set; }

        [DisplayName("Дата создания")]
        public DateTime CreateDate { get; set; }

        [DisplayName("Полный путь")]
        public string Path { get; set; }


        public List<int> TagIds
        {
            get
            {
                if (_tagIds == null)
                    _tagIds = string.IsNullOrEmpty(TagIdsStore) ? new List<int>() : new List<int>(TagIdsStore.Split(',').Select(int.Parse));
                return _tagIds;
            }
            set
            {
                _tagIds = value;
            }
        }

        public string TagIdsStore
        {
            get
            {
                if (_tagIds != null)
                    _tagIdsStore = string.Join(",", _tagIds);
                return _tagIdsStore;
            }
            set { _tagIdsStore = value; }
        }
    }
}
