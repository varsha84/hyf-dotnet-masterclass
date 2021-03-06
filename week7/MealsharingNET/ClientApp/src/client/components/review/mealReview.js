import React from "react";
import { useParams } from "react-router";
import {Form, Button, Row, Col, Container, Modal, Image } from 'react-bootstrap';
import { useHistory } from "react-router-dom";
import {getImageName} from "../../helper"

function AddMealReview(props){
    const params = useParams();
    const mealId = params.id;

    const [meal, setMeal] = React.useState("");
    const [description, setDescription] = React.useState("");
    const [stars, setStars] = React.useState(0);
    const [title, setTitle] = React.useState("");
    const [imageName, setImageName] = React.useState("");

    //back to meal page after submit
    let history = useHistory();

    const [validated, setValidated] = React.useState(false);

    React.useEffect(()=>{
        fetch(`/api/meals/${mealId}`)
        .then((response)=>response.json())
        .then((data)=>{
            console.log(data)
            setMeal(data)
            setImageName(getImageName(data.title))
        })
        .catch((e)=>console.log(e))

    },[])
    
    function handleSubmit(e){
        e.preventDefault();

        const form = e.currentTarget;
        if (form.checkValidity() === false) {
          e.preventDefault();
          e.stopPropagation();
        }
    
        setValidated(true);

        // new Review
        
        const newReview={
          title: title,
          description: description,
          meal_ID : mealId,
          stars : stars,
          created_date: new Date().toISOString().slice(0, 10),

        }
        console.log("review::"+ newReview);
        console.log("review::"+ newReview.stars);

        fetch("/api/reviews/", {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(newReview)
        })
        //.then(response => response.json())
        .then(data => {
            console.log(data)
            alert("Review Successfully submitted")
            history.push("/")
        })
        .catch(e => console.log(e));
    }
    return (
      <div>
      <div className="all-form "> 
          <h4>Review</h4>
          <Image  className="image-size" src={imageName} />
          <h4>{meal.title}</h4>
      </div>    
      <Form className="all-form" noValidte validated={validated} onSubmit={(e) => handleSubmit(e)}>  

        <Form.Group  className="mb-3">
          <Form.Label>Experience</Form.Label>
          <Form.Control type="text" placeholder="Meal Experience" onChange={(e)=> setTitle(e.target.value)} required/>
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label>Meal Description </Form.Label>
          <Form.Control type="text" placeholder="description" onChange={(e)=> setDescription(e.target.value)} required/>
        </Form.Group>

        <Form.Group className="mb-3">            
          <Form.Label>Rating</Form.Label>
          <Form.Control type="number" placeholder="rating" onChange={(e)=> setStars(e.target.value)} required/>      
        </Form.Group>
    <Button variant="primary" type="submit" >Submit</Button>
    </Form>
    </div>
 )
}
export default AddMealReview