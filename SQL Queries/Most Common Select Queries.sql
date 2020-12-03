-- the columns and info we'd want from a commits table
SELECT commitID, author, date, message
FROM commits;

-- the most recent commit, to check if db needs to update
SELECT commitID, author, message, MAX(date) as mostRecent
FROM commits, authors
WHERE commits.author = authors.author
ORDER BY date;

-- commits from a specific author 
SELECT commitID, author, date, message
FROM commits, authors 
WHERE authors.author = 'inputAuthor'
	AND commits.author = authors.author;

-- commits within a certain date range
SELECT * 
FROM commits
WHERE date < 'maxDate'
	AND date > 'minDate';

-- ordering the authors by the number of commits 
SELECT author, COUNT(author) as numcommits
FROM commits
GROUP BY author
ORDER BY numcommits DESC
LIMIT 1;

-- ordering author by numcommits within a date range
SELECT author, date, COUNT(author) as numcommits
FROM commits
WHERE date < 'maxDate'
	AND date > 'minDate'
GROUP BY author
ORDER BY numcommits DESC
LIMIT 1;

-- more queries that are just combos of the previous queries.
