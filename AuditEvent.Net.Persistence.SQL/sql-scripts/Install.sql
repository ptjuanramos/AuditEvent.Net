--Copyright 2021 AuditEvent.NET

--Licensed under the Apache License, Version 2.0 (the "License");
--you may not use this file except in compliance with the License.
--You may obtain a copy of the License at

--    http://www.apache.org/licenses/LICENSE-2.0

--Unless required by applicable law or agreed to in writing, software
--distributed under the License is distributed on an "AS IS" BASIS,
--WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
--See the License for the specific language governing permissions and
--limitations under the License.

BEGIN TRANSACTION;

-- Create the Audit schema if it doesn't exists
IF NOT EXISTS (SELECT [schema_id] FROM [sys].[schemas] WHERE [name] = '$(AuditEventSchema)')
BEGIN
    EXEC (N'CREATE SCHEMA [$(AuditEventSchema)]');
END

DECLARE @SCHEMA_ID int;
SELECT @SCHEMA_ID = [schema_id] FROM [sys].[schemas] WHERE [name] = '$(AuditEventSchema)';

-- Create the Audits table if not exists
IF NOT EXISTS(SELECT [object_id] FROM [sys].[tables] 
    WHERE [name] = 'Audits' AND [schema_id] = @SCHEMA_ID)
BEGIN
    CREATE TABLE [$(AuditEventSchema)].[Audits](
        Id          UNIQUEIDENTIFIER            DEFAULT NEWID(),
        Actor       NVARCHAR (MAX)              NOT NULL, 
        Input       NVARCHAR (MAX),
        Output      NVARCHAR (MAX),
        CONSTRAINT  [CONSTRAINTPK_Audits]       PRIMARY KEY(Id)
    );
    PRINT '[$(AuditEventSchema)].[Schema] table was created';
END
ELSE
    PRINT '[$(AuditEventSchema)].[Schema] schema already exists';

COMMIT TRANSACTION;