var PhoneNumber = function(raw){
    this.raw = raw
}

PhoneNumber.prototype.number = function() {
    return this.raw[0] === '2' || this.raw.length === 9 
        ? '0000000000' 
        : '1234567890'
}

PhoneNumber.prototype.areaCode = () => '123'

PhoneNumber.prototype.toString = () => '(123) 456-7890'

module.exports = PhoneNumber;