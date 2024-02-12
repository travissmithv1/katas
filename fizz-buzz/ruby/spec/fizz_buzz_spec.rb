require "fizz_buzz"

describe FizzBuzz, "process" do
  it "returns one when one" do
    fizzbuzz = FizzBuzz.new
    expect(fizzbuzz.process(1)).to eq(1)
  end
end
