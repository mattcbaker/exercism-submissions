module.exports = function(){
    this.toRna = toRna;
}

var map = {
    'C' : 'G',
    'G' : 'C',
    'A' : 'U',
    'T' : 'A'
};

function toRna(dna){
    return Array.prototype.map
        .call(dna, (c) => { return map[c]; })
        .join('');
}