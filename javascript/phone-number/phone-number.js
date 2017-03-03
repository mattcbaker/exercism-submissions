var PhoneNumber = function(raw){
    this.formatted = formatRaw(raw)
}

PhoneNumber.prototype.number = function() {
    return isValidPhoneNumber(this.formatted)
        ? this.formatted.slice(-10)
        : '0000000000'
}

PhoneNumber.prototype.areaCode = function() { 
    return this.formatted.slice(0,3) 
}

PhoneNumber.prototype.toString = function() {
    return `(${this.areaCode()}) ${this.formatted.slice(3,6)}-${this.formatted.slice(6)}`
}

var formatRaw = (raw) => raw.replace(/\D/g, '')

var isValidPhoneNumber = (number) => 
    number.length === 10 
    || (number.length === 11 && number[0] === '1')

module.exports = PhoneNumber;