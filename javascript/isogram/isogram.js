var Isogram = function(word){
    this.sanitized = word.replace(/(-|\s)/g, '').toLowerCase();
}

Isogram.prototype.isIsogram = function() {
        return this.sanitized.split('').filter((item, index, set) => {
            return set.indexOf(item) === index;
        }).length === this.sanitized.length;
}

module.exports = Isogram;