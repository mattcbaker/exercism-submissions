var Anagram = function(root){
    this.root = root.toLowerCase()
}

Anagram.prototype.matches = function(wordList){
    return wordList.filter((word) => {
        return JSON.stringify(groupLetter(word.toLowerCase())) === JSON.stringify(groupLetter(this.root)) && this.root !== word.toLowerCase()
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