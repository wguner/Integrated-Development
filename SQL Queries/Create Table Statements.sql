CREATE TABLE Commit(
    commit_id int NOT NULL AUTO_INCREMENT,
    commit_hash VARCHAR,
    email VARCHAR, 
    author VARCHAR, 
    message VARCHAR,
    datetime DATETIME,
	repoName VARCHAR,
	
    PRIMARY KEY(commit_id),
	FOREIGN KEY(repoName, commit_hash) REFERENCES Repository(repoName)
)

CREATE TABLE Author(
    author_id int NOT NULL AUTO_INCREMENT,
    name VARCHAR, 
    email VARCHAR, 

    PRIMARY KEY(author_id)
)

CREATE TABLE File (
    filename VARCHAR, 
    file_extension VARCHAR,
    PRIMARY KEY (filename)
)

CREATE TABLE FILE_MAP_COMMIT (
    filename VARCHAR,
    commit_id VARCHAR,
    FOREIGN KEY (filename) REFERENCES File(filename),
    FOREIGN KEY(commit_id) REFERENCES Commit(commit_id)
)

CREATE TABLE Repository (
	repoID int NOT NULL AUTO_INCREMENT,
	repoName VARCHAR,
	PRIMARY KEY(repoID)
)
--
CREATE TABLE Repository_map_commithash (
	repoName VARCHAR,
	commit_hash VARCHAR,
	FOREIGN KEY(repoName) REFERENCES Repository(repoName),
	FOREIGN KEY(commit_hash) REFERENCES Commit(commit_hash)
);

	