use Vente
GO


CREATE TABLE Article 
(
CodeArt INT PRIMARY KEY IDENTITY, 
Designation varchar(80), 
PU float, 
QStock int
)

SELECT * FROM Article