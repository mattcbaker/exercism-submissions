module.exports = function(word) {
    var sanizited = word.replace(/-/g, '').replace(' ', '').toLowerCase();

    this.isIsogram = () => {
        return sanizited.split('').filter((item, index, set) => {
            return set.indexOf(item) === index;
        }).length === sanizited.length;
    };
}