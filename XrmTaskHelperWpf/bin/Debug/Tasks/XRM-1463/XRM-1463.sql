select * from duRealization 
select * from duEntityActions where name like '%Отправить по E-mail%' or name like '%Привязать СИО по за%'
select * from duEntityActions where id = 264

select * from duWorker 

---------------------------------------------------------------------------------

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group])
values (3, '/Service/ClientServ/EditRemovalRate', 'Изменить коэф-т удаленности', 1, 2, null, null, 2, 1)

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group],[ParamMap])
values (3, '/Service/ClientServ/EditRemovalRate', 'Изменить коэф-т удаленности', 1, 2, null, 'ids[]', 1, 1,'ids[]-id')

----------------------------------------------------------------------------------

select workerId from dsClientAccess where roleId = 1132 order by clientId 

select * from duWorker where id in (select workerId from dsClientAccess where roleId = 1132 ) and loginDomain <> ''

select * from dsClientAccess where workerId = 949


