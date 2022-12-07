CREATE TABLe PERSONID (id int, Name varchar(255), Email varchar(255) );

CREATE TABLe PERSONID02 (id int, Name varchar(255), Email varchar(255) );

insert into PERSONId(id,name,email) 
values
 (1,'mohsin','mohsin@gmail.com'),

 (2,'Ali','Ali@gmail.com')



 insert into PERSONID02(id,name,email) 
values
 (1,'ubaid','ubaid@gmail.com'),

 (2,'Asad','Asad@gmail.com')

Select * from PERSONId
Select * from PERSONID02

Select * from PERSONId a inner join PERSONID02 b on a.id = b.id