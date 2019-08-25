import * as types from '../../actions/action-types';

// Initial state import
import initialState from '../initial-state';


const reducer = (state = initialState, action) => {


    switch (action.type) {

        case types.APPEND_CHAR:

            if(action.char === 'C') // C char is ignored and not added to the expression
                return { 
                    ...state,
                    inputEntry: '' // Reset of input entry
                };

            return {
                ...state,
                inputEntry: `${state.inputEntry+ action.char}`
            }

        case types.EVAULATE_EXPRESSION_SUCCESS: 

            return { 
                ...state,
                inputEntry: eval(state.inputEntry)
            };

        case types.EVAULATE_EXPRESSION_FAILURE: 

            return { 
                ...state,
                inputEntry: 'ERROR'
            };

        case  types.GET_HISTORY:

            return { 
                ...state,
                history: action.data,
            };

        case  types.GET_HISTORY_FAILURE:

            return { 
                ...state,
                history: 'ERROR',
            };
            


        }

    return state; 
}

export default reducer;