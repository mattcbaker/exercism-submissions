var compute = function (strand1, strand2) {
    if (strand1.length != strand2.length) {
        throw 'Strands must be the same length';
    }

    var intersect = strand1.split('').intersect(strand2.split(''));

    return strand1.length - intersect.length;
}

Array.prototype.intersect = function (compare) {
    var intersect = [];

    for (var i = 0; i < this.length; i++) {
        if (this[i] == compare[i]) {
            intersect.push(this[i]);
        }
    }

    return intersect;
}

module.exports = {
    compute : compute
};