module.exports = function(date){
    this.date = _ => new Date(date.getTime() + (Math.pow(10,9)*1000));
}