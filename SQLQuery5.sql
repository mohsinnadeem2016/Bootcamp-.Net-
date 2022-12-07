create trigger deep1
on t1
for
insert,delete
as
print'you can not delete this table i'
rollback;