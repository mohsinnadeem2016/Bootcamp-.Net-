create trigger saftey1
on database
for
drop_table
as
print'you can not create ,drop and alter table in this database'
rollback;