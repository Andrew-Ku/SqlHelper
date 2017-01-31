----------------------------------------------------------------
insert into duEntities (FullName) -- 121
values ('Xrm.Model.Worker.Role')

insert into duEntities (FullName) -- 124
values ('GridActions')

----��������------------------------------------------------------------------------------------------------------------

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group]) --673
values (121, '/Admin/Role/List', '����', 1, 1, null, '', 1, 1)

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group]) -- 674
values (121, '/Admin/Role/Add', '�������', 1, 1, null, '', 1, 1)

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group])  --675
values (121, '/Admin/Role/Edit', '�������������', 1, 1, null, 'id', 1, 1)

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group]) --676
values (121, '/api/Admin/Role', '�������', 1, 4, '�� �������, ��� ������ ������� ����', 'id', 1, 1)

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group]) --677
values (0, '/Admin/User/UserByLoginEdit', '������������', 1, 1, null, '', 1, 1)

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group],[ParamMap]) --680
values (112, '/Admin/UserAuth/UserRoles', '���� ������������', 1, 1, null, 'id', 1, 1, 'id-loginId')

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group],[ParamMap]) --681
values (112, '/Admin/UserAuth/AddUserRole', '��������', 1, 1, null, 'id', 1, 1, 'id-parentId')

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group],[ParamMap]) --682
values (112, '/api/Admin/UserAuth/RemoveUserRole', '�������', 1, 2, null, 'id,objectId', 1, 1, 'objectId-parentId')

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group]) -- 686
values (0, '/Admin/Authorization/AuthObjects', '������� �����������', 1, 1, null, '', 1, 1)

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group]) --687
values (124, '/Admin/Authorization/AddAuthObjectPolicy', '��������', 1, 1, null, 'qArea,qController,qAction,type', 1, 1) 

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group],[ParamMap]) -- 688
values (124, '/api/Admin/Authorization/RemoveAuthObjectPolicy', '�������', 1, 4, '�� �������, ��� ������ ������� ��������� ��������', 'id', 1, 1, '')

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group],[ParamMap]) -- 695
values (124, '/Admin/Authorization/PolicyRoles', '����', 1, 1, '', 'id', 1, 1, '')

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group],[ParamMap]) --696
values (124, '/Admin/Authorization/AddPolicyRole', '��������', 1, 1, null, 'parenId', 1, 1, '')

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group]) -- 697
values (0, '/Admin/Role/List', '����', 1, 1, null, '', 1, 1)

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group],[ParamMap]) -- 698
values (124, '/api/Admin/Authorization/RemovePolicyRole', '�������', 1, 2, null, 'id,objectId', 1, 1, 'objectId-parentId')

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group],[ParamMap]) --699
values (0, '/api/Admin/Authorization/ResetAuthCache', '�������� ��� �����������', 1, 2, '', '', 1, 2, '')

insert into duEntityActions (EntityId, Url, Name, IsAjax, Method, ConfirmMessage, UrlData, [Type], [Group],[ParamMap]) -- 700
values (121, '/Admin/Role/Users', '������������', 1, 1, '', 'id', 1, 1, '')
---------------------------------------------------------------------------------------------------------------------------------

-----����������-------------------------------------------------------------------------------------
--update duEntityActions set [Group]=2 where id = 699 
--update duEntityActions set Url = '/api/Admin/Authorization/RemoveAuthObjectPolicy' where id = 688
--update duEntityActions set UrlData = 'id,objectId' where id in (682,698 )
------------------------------------------------------------------------------------------------

select * from duEntityActions where id >671 entityId = 92
select * from duEntityActions where entityId = 124
select * from duEntityActions where Name like '%���������%'

select * from duEntities where id = 112
select * from duEntities where FullName like '%User%'


use dev

select * from duWorker where id = 1655
select * from dsWorker

select * from dmRole

use worker
select dsWorker.ID, Family, dsWorker.Name, SecondName, Login, DS.Name 
from webpages_UsersInRoles 
left join dsWorker on dsWorker.ID = webpages_UsersInRoles.UserID
left join dsDepartmentSprav DS on DS.ID = dsWorker.Department
where RoleID in (171)


select * from dsWorker where IsWorking =1 and Login is not null