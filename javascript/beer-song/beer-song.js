function BeerSong(){}

BeerSong.prototype.verse = function(verse) {
    return `${mapToBeginningSequence(verse)}${mapToEndingSequence(verse)}`
}

BeerSong.prototype.sing = function(start, end) {
    end = end === undefined ? 0 : end

    return new Array(start - (end - 1))
        .fill()
        .map((_, index) => {
            return new BeerSong().verse(start - index)
        }).join('\n')
}

const beginningSequence = {
    '1': '1 bottle of beer on the wall, 1 bottle of beer.\n',
    '0': 'No more bottles of beer on the wall, no more bottles of beer.\n'
}

function mapToBeginningSequence(verse) {
    return beginningSequence.hasOwnProperty(verse) 
        ? beginningSequence[verse] 
        : `${verse} bottles of beer on the wall, ${verse} bottles of beer.\n`
}

const endingSequence = {
    '2': `Take one down and pass it around, 1 bottle of beer on the wall.\n`,
    '1': `Take it down and pass it around, no more bottles of beer on the wall.\n`,
    '0': 'Go to the store and buy some more, 99 bottles of beer on the wall.\n'
}

function mapToEndingSequence(verse){
    return endingSequence.hasOwnProperty(verse) 
        ? endingSequence[verse]
        : `Take one down and pass it around, ${verse - 1} bottles of beer on the wall.\n`
}

module.exports = BeerSong;