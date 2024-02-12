class FizzBuzz
  def process(value)
    return "fizzbuzz" if is_divisible_by_fifteen(value)
    return "fizz" if is_divisible_by_three(value)
    return "buzz" if is_divisible_by_five(value)
    value
  end

  private

  def is_divisible_by_fifteen(value)
    value % 15 == 0
  end

  def is_divisible_by_five(value)
    value % 5 == 0
  end

  def is_divisible_by_three(value)
    value % 3 == 0
  end
end
