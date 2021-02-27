CREATE VIEW Author_Map_Repo AS
	SELECT DISTINCT author_id, repo_id
	FROM Commit
