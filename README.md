# Hexacrypt
Simple text-based encryption algorithm

<br>

## Features of Hexacrypt
---

1. Requires a "Secret Key" to encode and decode messages.

2. All input and output is done in text characters, so there is no need to worry about hexadecimal bytes.

3. The same input and key can produce completely different outputs of different lengths. Look at some of the outputs for the message "Hello!"
   * |P6]Cj\\j\'E!P-Gs
   * ZNDH36[sRjFK"x]+~
   * i2Bf\`q{i "XnT\\^9

<br>

## Weaknesses
---

1. Not secure - uses seed with insecure pseudo-random number generator to shuffle string

2. Platform dependent - Different random number algorithms produce different messages

<br>

## The Algorithm
---

### Step 1: Filter
This is a simple enough step. The computer removes any “illegal characters”, such as emoji’s, special letters, etc. from the message and secret key. Any of these characters would mess up the encryption process.
<br>

### Step 2: Get Seed
Using the secret key provided, the computer adds up all of the ascii character values to get a number. This number then becomes the seed for the random number generator.
<br>

### Step 3: Shuffle Characters
