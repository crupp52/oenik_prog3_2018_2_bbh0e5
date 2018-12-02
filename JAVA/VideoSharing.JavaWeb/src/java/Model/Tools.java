package Model;

import java.util.Random;

public class Tools {

    private String[] names;
    
    public Tools() {
    }
    
    public String RandomUsernameGenerator(boolean gender){
        Random rnd = new Random();
        
        if (gender) {
            this.names = new String[] {"James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Thomas", "Charles", "Christopher", "Daniel", "Matthew", "Anthony", "Donald", "Mark", "Paul", "Steven", "Andrew", "Kenneth", "George", "Joshua", "Kevin", "Brian", "Edward", "Ronald", "Timothy", "Jason", "Jeffrey", "Ryan", "Jacob", "Gary", "Nicholas", "Eric", "Stephen", "Jonathan", "Larry", "Justin", "Scott", "Brandon", "Frank", "Benjamin", "Gregory", "Raymond", "Samuel", "Patrick", "Alexander", "Jack", "Dennis", "Jerry", "Tyler", "Aaron", "Henry", "Jose", "Douglas", "Peter", "Adam", "Nathan", "Zachary", "Walter", "Kyle", "Harold", "Carl", "Jeremy", "Gerald", "Keith", "Roger", "Arthur", "Terry", "Lawrence", "Sean", "Christian", "Ethan", "Austin", "Joe", "Albert", "Jesse", "Willie", "Billy", "Bryan", "Bruce", "Noah", "Jordan", "Dylan", "Ralph", "Roy", "Alan", "Wayne", "Eugene", "Juan", "Gabriel", "Louis", "Russell", "Randy", "Vincent", "Philip", "Logan", "Bobby", "Harry", "Johnny"};
        }else{
            this.names = new String[] {"Mary", "Patricia", "Jennifer", "Linda", "Elizabeth", "Barbara", "Susan", "Jessica", "Sarah", "Margaret", "Karen", "Nancy", "Lisa", "Betty", "Dorothy", "Sandra", "Ashley", "Kimberly", "Donna", "Emily", "Carol", "Michelle", "Amanda", "Melissa", "Deborah", "Stephanie", "Rebecca", "Laura", "Helen", "Sharon", "Cynthia", "Kathleen", "Amy", "Shirley", "Angela", "Anna", "Ruth", "Brenda", "Pamela", "Nicole", "Katherine", "Samantha", "Christine", "Catherine", "Virginia", "Debra", "Rachel", "Janet", "Emma", "Carolyn", "Maria", "Heather", "Diane", "Julie", "Joyce", "Evelyn", "Joan", "Victoria", "Kelly", "Christina", "Lauren", "Frances", "Martha", "Judith", "Cheryl", "Megan", "Andrea", "Olivia", "Ann", "Jean", "Alice", "Jacqueline", "Hannah", "Doris", "Kathryn", "Gloria", "Teresa", "Sara", "Janice", "Marie", "Julia", "Grace", "Judy", "Theresa", "Madison", "Beverly", "Denise", "Marilyn", "Amber", "Danielle", "Rose", "Brittany", "Diana", "Abigail", "Natalie", "Jane", "Lori", "Alexis", "Tiffany", "Kayla"};
        }
        
        return this.names[rnd.nextInt(100)]+rnd.nextInt(1000);
    }
}