--13991225
declare @id int
select @id=id from texam where xyear=1399 and term=3

update tmark set M2=mark where Xtest=@id and m2 is null
and xstudent in(select xstudent from tYear_Student where xYear=1399 and MarkTerm3_From100=1)
GO
UPDATE    tVer
                         SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQlVBRThBU0FCb0FFNEFZUUJVQUdnQU5RQlVBR3dBUlFCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO