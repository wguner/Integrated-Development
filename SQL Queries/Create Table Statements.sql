CREATE TABLE Commit(
    commit_id SERIAL,
    commit_hash VARCHAR,
    email VARCHAR, 
    author VARCHAR, 
    message VARCHAR,
    datetime TIMESTAMP,
	repoName VARCHAR,
	
    PRIMARY KEY(commit_id),
	FOREIGN KEY(repoName, commit_hash) REFERENCES Repository(repoName)
);

CREATE TABLE Author(
    author_id SERIAL,
    name VARCHAR, 
    email VARCHAR, 

    PRIMARY KEY(author_id)
);

CREATE TABLE File (
    filename VARCHAR, 
    file_extension VARCHAR,
    PRIMARY KEY (filename)
);

CREATE TABLE FILE_MAP_COMMIT (
    filename VARCHAR,
    commit_id SERIAL,
    FOREIGN KEY (filename) REFERENCES File(filename),
    FOREIGN KEY(commit_id) REFERENCES Commit(commit_id)
);

CREATE TABLE Repository (
	repoID SERIAL,
	repoName VARCHAR,
	PRIMARY KEY(repoID)
);
--
CREATE TABLE Repository_map_commithash (
	repoName VARCHAR,
	commit_hash VARCHAR,
	FOREIGN KEY(repoName) REFERENCES Repository(repoName),
	FOREIGN KEY(commit_hash) REFERENCES Commit(commit_hash)
);

	