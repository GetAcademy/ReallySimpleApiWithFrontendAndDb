
-- Create
INSERT INTO Contacts
VALUES ('x', 'x@gmail.com')

-- Read
SELECT *
FROM Contacts

SELECT *
FROM Contacts
WHERE Name = 'Terje'

-- Update
UPDATE Contacts
SET Email = 'pal@gmail.com'
WHERE Name = 'Pål'

-- Delete
DELETE FROM Contacts
WHERE Name = 'x'
