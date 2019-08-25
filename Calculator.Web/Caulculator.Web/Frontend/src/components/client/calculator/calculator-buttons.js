import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import * as calculatorActions from '../../../actions/calculator-action';
import ShortId from 'shortid';

import '../../../styles/submit-button.scss';

// Boostrap modules
import { Button } from 'reactstrap';

class Buttons extends Component {

    calculationFeatures = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '*', '/', 'C'];

    sendCharacter = (character) => {

        this.props.actions.appendCharacter(character);
        
    }
  
    calculate = () => {

        const data = {
            expression: this.props.inputEntry,
            result: eval(this.props.inputEntry)
        }

        this.props.actions.addNew(data,() => {

            this.props.actions.getHistory();
        });
        
    }

    componentDidMount() {

        this.props.actions.getHistory();   
    }



    getContent = () => {

        return (

            <div className="container">

                <div className="input-field">
                <span className="input-title ">Vyraz:</span>
                    {this.props.inputEntry}
                </div>

                <br/>


               
                <div className="row input-area">

                   
                    {this.calculationFeatures.map(arg =>

                        <div className="input-button" key = {ShortId.generate()}> 

                            <Button className="btn-group btn-group-lg btn-block" onClick={() => this.sendCharacter(arg)} > {arg} </Button>

                        </div> 
                    )}
                </div>


                

                <div>
                    <Button className="submit-button btn-block" onClick={() => this.calculate()}>Spočitej </Button>
                </div>
            </div>

        );
    }


    render() {

        return (

            <div>
                {this.getContent()}

                
            </div>
        )
    }

}

const mapDispatchToProps = (dispatch) => {

    return {
        actions: bindActionCreators(calculatorActions, dispatch)
    };

}


const mapStateToProps = (state) => {
    return {
        inputEntry: state.calculatorOperations.inputEntry,
        history: state.calculatorOperations.history
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(Buttons);
