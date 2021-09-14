using System;

namespace Prime {
    public string primeMultiples(int input) {
        // list of known primes
        List<int> primes = new List<int>{2,3,5,7,11,13,17};
        // dictionary to hold factors of input
        Dictionary<int, int> factors = new Dictionary<int, int>();

        // input that we can alter
        int changeInput = input;
        // for every prime number in primes list
        for(int i = 0; i < primes.Count; i++) {
            // if input modulus prime equals 0
            if(changeInput % primes[i] == 0) {
                // add to factors dictionary
                factors.Add(primes[i], factors[primes[i]]++);
                // manipulate input to reflect factoring
                changeInput /= primes[i];
                // counteract the increment to see if prime factors into input multiple times
                i--;
            }
            // if input equals zero, dont test any more primes
            if(changeInput == 0) {
                break;
            }
        }

        // holds return value
        string answer = "";
        // check every key value pair
        foreach(KeyValuePair<int, int> kvp in factors) {
            // if value is 1, only factors into input once
            if(kvp.Value == 1) {
                answer += kvp.Key;
            }
            // otherwise, include how many times prime factors into input
            else {
                answer += kvp.Key + "^" + kvp.Value;
            }
            answer += " x ";
        }

        // return answer from function
        return answer;
    }
}

