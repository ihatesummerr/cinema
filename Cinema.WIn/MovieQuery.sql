SELECT m.Id,
	m.Title,
	c.Name Country,
	m.Release_Date,
	g.Name Genre,
	d.FirstName || d.LastName Director,
	m.Length,
	m.Poster,
	m.Description
FROM movies m
JOIN countries c ON (m.Country_Id = c.Id)
JOIN genres g ON (m.Genre_Id = g.Id)
JOIN directors d ON (m.Director_Id = d.Id)