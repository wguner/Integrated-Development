CREATE TABLE Author(
    author_id SERIAL,
    name VARCHAR, 
    email VARCHAR, 
    PRIMARY KEY(author_id)
);

CREATE TABLE Repository (
	repo_id SERIAL,
	repoURL VARCHAR,
	PRIMARY KEY(repo_id)
);

CREATE TABLE File (
    filename VARCHAR,
    file_id SERIAL, 
    file_extension VARCHAR,
	repo_id INTEGER,
    PRIMARY KEY (file_id),
	FOREIGN KEY (repo_id) REFERENCES Repository(repo_id)
);

CREATE TABLE Commit(
    commit_id SERIAL,
    commit_hash VARCHAR,
    email VARCHAR, 
    author VARCHAR, 
    message VARCHAR,
    datetime TIMESTAMP,
	repo_id INTEGER,
	FOREIGN KEY(repo_id) REFERENCES Repository(repo_id),
	
    PRIMARY KEY(commit_id)
);

CREATE TABLE FILE_MAP_COMMIT (
    file_id INTEGER,
    commit_id INTEGER,
    FOREIGN KEY (file_id) REFERENCES File(file_id),
    FOREIGN KEY(commit_id) REFERENCES Commit(commit_id)
);
