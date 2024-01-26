/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

Set Identity_Insert Sections On

INSERT INTO Sections(Id, SectionName) VALUES(1, '.NET Cybersécurité')

Set Identity_Insert Sections Off

Set Identity_Insert Students On

INSERT INTO Students(Id, Firstname, Lastname, Birthdate, YearResult,SectionId, Active) VALUES
(1, 'David', 'Delangh', '01-04-2000', 17, 1, 1)

Set Identity_Insert Students Off
