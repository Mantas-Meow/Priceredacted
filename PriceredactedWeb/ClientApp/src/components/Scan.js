import React, { useState } from 'react';
import './Buttons.css'
import { TestProductsData } from './TestProductsData'
import { makeStyles } from '@material-ui/core/styles';
import Grid from '@material-ui/core/Grid';
import Paper from '@material-ui/core/Paper';
import Typography from '@material-ui/core/Typography';
import ButtonBase from '@material-ui/core/ButtonBase';

const useStyles = makeStyles((theme) => ({
    root: {
        margin: 2,
        flexGrow: 1,
    },
    product: {
        margin: 2,
        padding: 2,
    },
    productWindow: {
        padding: theme.spacing(2),
        backgroundColor: 'var(--table-color-secondary)',
        minWidth: 300,
    },
    paper: {
      padding: theme.spacing(2),
     
      display: 'block',
      maxWidth: '25%',
      maxHeight: '25%',
      minWidth: 300,
      minHeight: 300,
    },
    image: {
     
    },
    img: {
      margin: 'auto',
      display: 'block',
      maxWidth: '100%',
      maxHeight: '100%', 
    },
  }));

 function fetchAPI() {
    // param is a highlighted word from the user before it clicked the button
    return fetch("https://localhost:5001/api/products");
  }

function Scan() {
    const [products, setProducts] = useState([]);
    const [compared, setCompared] = useState([]);
    const [count, setCount] = useState(0);
    const [upload, setUpload] = useState(0);
    const [scan, setScan] = useState(0);
    const [image, setImage] = useState(null);
    const [base64String, setImageString] = useState(0);
    const classes = useStyles();

    const [fetchedString, setFetchedString] = useState(0);

    const handleImageUpload = event => {
        let reader = new FileReader();
        reader.onload = function(e) {
            setImage(e.target.result);
            setUpload(true);
            var img = e.target.result;
            setImageString(img.replace("data:image/png;base64,", ""));
          };
        reader.readAsDataURL(event.target.files[0]);
    }

    async function fetchButtonClick() {
        const response = await fetchAPI();
        const result = await response.json();
        setProducts(result);
        setUpload(true);
    }

    async function scanImage() {
        const data = {imageString: base64String}
        const requestOptions = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'},
            body: JSON.stringify(data)
        };
        const response = await fetch('https://localhost:5001/api/ScanPage/Scan', requestOptions);
        const result = await response.json();
        setProducts(result);
        console.log(result);
        comparePrices(result);
    }

    async function comparePrices(prod) {
        //console.log(prod);
        const requestOptions = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'},
            body: JSON.stringify(prod)
        };
        const response = await fetch('https://localhost:5001/api/ScanPage/Compare', requestOptions);
        const result = await response.json();
        setCompared(result);
        setScan(true);
    }

    return (
        <main>
            <span className="headline-text">Scan receipt</span>

            <div className={classes.root}>
                <p style={{ 'padding': '0.5rem'}}></p>
                
                <Grid container direction="row" spacing={4}>
                                    
                    <Grid item>
                        <input id="imageFile" type="file" onChange={handleImageUpload}/>
                        {
                        // <button className="basicButton" onClick={() => setUpload(true)}>Upload</button>
                        }
                    </Grid>
                    {
                        upload == true &&
                        <Grid item xs={2}>
                            <button className="basicButton" onClick={() => {setUpload(false); setScan(false)}}>Delete</button>
                        </Grid>
                    }
                    {
                        upload == true &&
                        <Grid item>
                            <button className="basicButton" onClick={scanImage}>Scan</button>
                        </Grid>
                    }
                    
                </Grid>
                
                <Grid container justify="center" direction="row" spacing={6}>
                    <Grid className={classes.paper} item xs={4}>
                        <Grid item xs>
                        {
                            upload == true &&
                            <img src={image} alt={""} className={classes.img}/>
                        }  
                        </Grid>
                    </Grid>
                    <Grid container item xs>
                        <Paper className={classes.productWindow}>Products
                        {   scan == true &&
                            <Grid container justify="center" direction="row">
                                <Grid container wrap="nowrap" direction="column" spacing={1}>
                                {
                                    products.map((item, index) => {
                                        return(
                                            <Grid key={index} container direction="row" item xs>
                                                <Paper variant="outlined" elevation={2} className={classes.product}>
                                                <span style={{'float':'left', 'padding':'0rem 1rem'}}>{item.name}</span>
                                                <span style={{'float':'right', 'padding':'0rem 1rem'}}>{item.price}</span>​                                           
                                                </Paper>
                                                {compared[index].shop != "-" ? 
                                                <Paper variant="outlined" elevation={2} className={classes.product}>
                                                    {
                                                    compared[index].compared.toFixed(2) > 0 ?
                                                    <div>
                                                        <span style={{'float':'left', 'padding':'0rem 1rem', 'color': 'red', 'fontWeight': 'bold'}}>{compared[index].shop}</span>
                                                        <span style={{'float':'right', 'padding':'0rem 1rem', 'color': 'red', 'fontWeight': 'bold'}}>+{compared[index].compared.toFixed(2)}</span>
                                                    </div>
                                                    :
                                                    <div>
                                                        <span style={{'float':'left', 'padding':'0rem 1rem', 'color': 'green', 'fontWeight': 'bold'}}>{compared[index].shop}</span>
                                                        <span style={{'float':'right', 'padding':'0rem 1rem', 'color': 'green', 'fontWeight': 'bold'}}>{compared[index].compared.toFixed(2)}</span>
                                                    </div>
                                                    }
                                                                                           
                                                </Paper> : ""}
                                            </Grid>
                                            
                                            
                                        )
                                    })
                                }
                                </Grid>
                            </Grid>
                        }
                        </Paper> 
                    </Grid>
                </Grid>

                {/* <Grid>
                    <Grid container justify="center" spacing={3}>
                        <Grid item xs>
                            <Paper className={classes.paper}>
                                <Grid container spacing={2}>
                                    <Grid item>
                                        <ButtonBase className={classes.image}>
                                            <img className={classes.img} alt="complex" src={require("../Resources/PriceRedacted.png")}/>
                                        </ButtonBase>
                                    </Grid>
                                    <Grid item xs={12} sm container>
                                        <Grid item xs container direction="column" spacing={2}>
                                            <Grid item xs>
                                                <Typography gutterBottom variant="subtitle1">
                                                    Standard license
                                                </Typography>
                                                <Typography variant="body2" gutterBottom>
                                                    Full resolution 1920x1080 • JPEG
                                                </Typography>
                                                <Typography variant="body2" color="textSecondary">
                                                    ID: 1030114
                                                </Typography>
                                            </Grid>
                                        <Grid item>
                                            <Typography variant="body2" style={{ cursor: 'pointer' }}>
                                            Remove
                                            </Typography>
                                        </Grid>
                                    </Grid>
                                    <Grid item>
                                        <Typography variant="subtitle1">$19.00</Typography>
                                    </Grid>
                                </Grid>
                    </Grid>
                            </Paper>

                        </Grid>
                            <Grid item xs>
                                <Paper className={classes.paper}>
                                <Grid>    
                <table style={{'backgroundColor': 'var(--bg-primary)'}} className="table table-sm table-hover table-dark">
                    <thead>
                        <tr>
                        <th scope="col">Shop</th>
                        <th scope="col">Name</th>
                        <th scope="col">Price</th>
                        </tr>
                    </thead>
                    <tbody>
                        {TestProductsData.map((item, index) => {
                            return(
                                <tr key={index}>
                                <td>{item.shop}</td>
                                <td>{item.name}</td>
                                <td>{item.price}</td>
                                </tr>
                            )
                        })}
                    </tbody>
                </table>
                </Grid>
                                </Paper>
                            </Grid>
                    </Grid>
                </Grid> */}
            </div>
        </main>
    )
}
export default Scan;