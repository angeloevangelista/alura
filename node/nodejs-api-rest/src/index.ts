import express from 'express';

const port = process.env.PORT || 3333;

const app = express();

app.listen(port, () =>
  console.log(`Server running at http://127.0.0.1:${port}`),
);

app.get('/', (request, response) => response.send('Everything is OK.'));
