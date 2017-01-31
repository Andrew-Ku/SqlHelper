create table pcTest
( ID int NOT NULL IDENTITY(1,1),
  number decimal(18,8) NULL,
)

insert into pcTest (number)
values(1323.343123243546576767)

select * from pcTest


ALTER TABLE pcTest ALTER COLUMN number decimal(12,8)
select * from dmSupply

------------------------------------------------

ALTER TABLE dmSupply ALTER COLUMN Discont decimal(18,8)
select * from dmSupply

--------------------------------------------------------

