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
}
CREATE TABLE File (
	commit_id VARCHAR, 
	file_extension VARCHAR,
	name VARCHAR,
	FOREIGN KEY(commit_id) REFERENCES Commit(commit_id)
)
CREATE TABLE Date (
	commit_id VARCHAR,
	month VARCHAR, 
	day VARCHAR,
	year VARCHAR, 
	time VARCHAR,
	FOREIGN KEY(commit_id) REFERENCES Commit(commit_id)
)