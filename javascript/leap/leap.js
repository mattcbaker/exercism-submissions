module.exports = function(year){
    this.isLeap = () => { return isLeap(year) }
}

function isLeap(year){
    return year % 4 === 0 && (year % 100 !== 0 || year % 400 === 0);
}