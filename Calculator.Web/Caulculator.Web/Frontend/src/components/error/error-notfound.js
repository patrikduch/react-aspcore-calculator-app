import React from 'react';
import { Link } from 'react-router-dom';


// Get routes
import { routes } from '../../routing/routes'; 

const ErrorNotFound = () => {

    return (
        <div>
            404!
            <Link to={ routes.rootPageUrl }>Go home</Link>
        </div>
    )
};


export default ErrorNotFound;