module.exports = function(sentence){
    this.isPangram = () => { return isPangram(sentence); };
}

var mustContain = 'abcdefghijklmnopqrstuvwxyzx';

function isPangram(sentence){
    var sanitized = sentence.toLowerCase();
    
    return Array.prototype.every
        .call(mustContain, (c) => { return sanitized.indexOf(c) > -1; });    
}