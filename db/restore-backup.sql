DECLARE @dbname NVARCHAR(128)
SET @dbname = N'MyWebsiteDb'

IF (NOT EXISTS (SELECT name
FROM master.sys.databases
WHERE ('['+ name + ']'= @dbname
OR name = @dbname)))

BEGIN

    RESTORE DATABASE @dbname 
    FROM DISK = '/tmp/MyWebsiteDb.bak'
    WITH FILE = 1,
    MOVE N'MyWebsiteDb' TO N'/var/opt/mssql/data/MyWebsiteDb.mdf', 
    MOVE N'MyWebsiteDb_Log' TO N'/var/opt/mssql/data/MyWebsiteDb_log.ldf', 
    NOUNLOAD, STATS = 5

END

ELSE
BEGIN
    ALTER DATABASE MyWebsiteDb
    SET OFFLINE WITH ROLLBACK IMMEDIATE;

    RESTORE DATABASE @dbname 
    FROM DISK = '/tmp/MyWebsiteDb.bak'
    WITH FILE = 1,
    MOVE N'MyWebsiteDb' TO N'/var/opt/mssql/data/MyWebsiteDb.mdf', 
    MOVE N'MyWebsiteDb_Log' TO N'/var/opt/mssql/data/MyWebsiteDb_log.ldf', 
    NOUNLOAD, REPLACE, STATS = 5
END