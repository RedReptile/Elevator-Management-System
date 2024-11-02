CREATE TABLE DataLogs (
    LogID INT PRIMARY KEY IDENTITY(1,1),      -- Unique identifier for each log entry
    Action VARCHAR(50) NOT NULL,              -- Description of the action (e.g., 'Open Door', 'Request Floor 1')
    Details VARCHAR(100),                     -- Additional details, such as the current or target floor
    Timestamp DATETIME DEFAULT GETDATE()      -- Automatically records the date and time of the log entry
);


SELECT * FROM DataLogs;

DROP TABLE DataLogs;

SELECT Action, Details, Timestamp 
FROM DataLogs order by Timestamp desc;


TRUNCATE TABLE DataLogs;