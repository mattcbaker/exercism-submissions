var words = function (input) {
    var split = input.split(/\s+/);
    var counts = {};

    for (var i = 0; i < split.length; i++) {
        if (!(counts.hasOwnProperty(split[i]))) {
            counts[split[i]] = 0;
        }

        counts[split[i]]++;
    }

    return counts;
};

module.exports = words;