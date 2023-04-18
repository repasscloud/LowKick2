# Replace "input.txt" with the path to your input file
$inputFile = Get-Content "source.txt"


## UPPER CASE ##
# Define a regular expression to match words starting with a capital letter
$regex = "[A-Z][a-z]*"

# Create an empty array to store the matched words
$matchedWords = @()

# Loop through each line in the input file
foreach ($line in $inputFile) {
    # Find all matches of the regular expression in the line
    $matches = [regex]::Matches($line, $regex)

    # Loop through each match and add it to the array of matched words
    foreach ($match in $matches) {
        $matchedWords += $match.Value
    }
}

# Replace "output.txt" with the path to your output file
$matchedWords | Select-Object -Unique | Out-File "capital_output.txt"

# Return only


## LOWER CASE ##
# Define a regular expression to match words starting with a capital letter
$regex = "[a-z]*"

# Create an empty array to store the matched words
$matchedWords = @()

# Loop through each line in the input file
foreach ($line in $inputFile) {
    # Find all matches of the regular expression in the line
    $matches = [regex]::Matches($line, $regex)

    # Loop through each match and add it to the array of matched words
    foreach ($match in $matches) {
        $matchedWords += $match.Value
    }
}

# Replace "output.txt" with the path to your output file
$matchedWords | Select-Object -Unique | Where-Object {$_ -ne ""} | Out-File "lower_output.txt"