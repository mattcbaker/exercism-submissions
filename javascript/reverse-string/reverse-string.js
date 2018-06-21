module.exports = (word) => {
  var result = ''

  for (var i = word.length; i > 0; i--) {
    result += word[i - 1]
  }

  return result
}