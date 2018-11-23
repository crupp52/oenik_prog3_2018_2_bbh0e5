/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Model;

import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author ggabo
 */

@XmlRootElement
@XmlAccessorType(XmlAccessType.FIELD)
public class People {    
    
    @XmlElement
    List<Person> person;   

    public People() {
        person = new ArrayList<>();
        
        person.add(new Person("Test Elek", 44));
        person.add(new Person("Proba Bela", 14));
    }  
    
    public List<Person> getPeople() {
        return person;
    }
}
