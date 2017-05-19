var Anagram = function(word){
    this.word = word.toLowerCase()
}

Anagram.prototype.matches = function(wordList){
    var forFilter = Array.isArray(wordList) ? wordList : Object.keys(arguments).map(key => arguments[key]);
    return forFilter.filter((word) => {
        return JSON.stringify(groupLetter(word.toLowerCase())) === JSON.stringify(groupLetter(this.word)) && this.word !== word.toLowerCase()
    })
}

function groupLetter(word){
    return word
            .split('')
            .sort()
            .reduce((grouping, letter) => {
                if(grouping.hasOwnProperty(letter)){
                    grouping[letter]++
                } else {
                    grouping[letter] = 1
                }

                return grouping
            }, {})
}

module.exports = Anagram