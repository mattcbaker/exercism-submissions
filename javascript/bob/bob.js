var Bob = function () { };

Bob.prototype.hey = function (input) {
    return this.getResponse(input);
};

Bob.prototype.getResponse = function (input) {
    var response = 'Whatever.';

    for (var i = 0; i < toneBank.length; i++) {
        if (toneBank[i].check(input)) {
            response = toneBank[i].response;
            break;
        }
    }

    return response;
}

var toneBank = [
    {
        check: function (input) {
            return (input.toUpperCase() == input && /[a-zA-Z]/.test(input));
        },
        response: 'Whoa, chill out!'
    },
    {
        check: function (input) {
            return input.indexOf('?', input.length - 1) !== -1;
        },
        response: 'Sure.'
    },
    {
        check: function (input) {
            return (input.replace(/\s/g, '').length == 0);
        },
        response: 'Fine. Be that way!'
    }
];

module.exports = Bob;