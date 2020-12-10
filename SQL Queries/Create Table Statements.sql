CREATE TABLE Commit(
	commit_id VARCHAR PRIMARY KEY,
	email VARCHAR, 
	author VARCHAR, 
	message VARCHAR,
	PRIMARY KEY(commit_id)
)
CREATE TABLE Author(
	name VARCHAR, 
	email VARCHAR, 
	PRIMARY KEY(email)
)
CREATE TABLE File (
	commit_id VARCHAR,
	filename VARCHAR, 
	file_extension VARCHAR,
	PRIMARY KEY (filename, commit_id),
	FOREIGN KEY (commit_id) REFERENCES Commit(commit_id)
)

CREATE TABLE Date (
	commit_id VARCHAR,
	month VARCHAR, 
	day VARCHAR,
	year VARCHAR, 
	time VARCHAR,
	FOREIGN KEY(commit_id) REFERENCES Commit(commit_id)
)

--no longer needed?--
CREATE TABLE FILE_MAP_COMMIT (
	filename VARCHAR,
	commit_id VARCHAR,
	FOREIGN KEY (filename) REFERENCES File(filename),
	FOREIGN KEY(commit_id) REFERENCES Commit(commit_id)
)