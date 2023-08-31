const sqlite3 = require('sqlite3').verbose();

let db = new sqlite3.Database('Database.db');

let sql = `SELECT Pulse FROM Settings`;
db.each(sql, [], (err, rows) => {
    if (err) {
        throw err;
    }
    z = rows.Pulse + 1
});

db.close();

db.each(sql, [], (err, rows) => {
    if (err) {
        throw err;
    }
    z = rows.Pulse + 1
    Pulsedb(z)
});

function Pulsedb(id){
    var sql2 = "UPDATE Settings SET Pulse = " + id;
    db.each(sql2, [], (err, rows) => {
        if (err) {
            throw err;
        }
        console.log(rows);
    });
    monke()
}
function monke(){
    var sql2 = "UPDATE Settings SET Pulse = 0";
    db.each(sql2, [], (err, rows) => {
        if (err) {
            throw err;
        }
        console.log(rows);
    });
}