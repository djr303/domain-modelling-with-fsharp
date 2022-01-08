type Club = char
type Heart = char
type Diamond = char
type Spade = char

type Rank = Two | Three | Four | Five | Six | Seven | Eight | Nine | Ten | Jack | Queen | King
type Suit = Club | Diamond | Spade | Heart
type Card = Suit * Rank

let club: Club = "C"
let heart: Heart = "H"
let diamond: Diamond = "D"
let spade: Spade = "S"

let suits: Suit array = [|"C", "D", "H", "S"|]

// let giveMeASuit = oneOf(Suit)
// let giveMeACard = (giveMeASuit, giveMeARank): Card