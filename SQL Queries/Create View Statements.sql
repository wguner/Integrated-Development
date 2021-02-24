
CREATE VIEW AuthorRepoView
AS
SELECT Author.author_id, Author.name, Repository.repoURL
    FROM AUTHOR
        FULL OUTER JOIN Author_Map_Repo
            ON Author.author_id = Author_Map_Repo.author_id
                FULL OUTER JOIN Repository
                    on Repository.repo_id = Author_Map_Repo.repo_id