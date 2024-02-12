require 'fizz_buzz'

RSpec.describe FizzBuzz, "process" do
  before do
    @fizzbuzz = FizzBuzz.new
  end

  it "returns one when provided one" do
    expect(@fizzbuzz.process(1)).to eq(1)
  end

  it "returns fizz when provided three" do
    expect(@fizzbuzz.process(3)).to eq("fizz")
  end

  it "returns buzz when provided five" do
    expect(@fizzbuzz.process(5)).to eq("buzz")
  end

  it "returns fizzbuzz when provided fifteen" do
    expect(@fizzbuzz.process(15)).to eq("fizzbuzz")
  end
end
