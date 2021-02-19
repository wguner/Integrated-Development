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
    author_id INTEGER, 
    message VARCHAR,
    datetime TIMESTAMP,
	repo_id INTEGER,
    PRIMARY KEY(commit_id),
	FOREIGN KEY(repo_id) REFERENCES Repository(repo_id)
);

CREATE TABLE File_Map_Commit (
    file_id INTEGER,
    commit_id INTEGER,
    FOREIGN KEY (file_id) REFERENCES File(file_id),
    FOREIGN KEY(commit_id) REFERENCES Commit(commit_id)
);
