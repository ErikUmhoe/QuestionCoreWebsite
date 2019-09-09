import {Component} from '@angular/core'
import { ApiService } from './api.service'

@Component({
    templateUrl: './question.component.html',
    selector: 'question'
})
export class QuestionComponent
{

    question ={}
    
    constructor(private api: ApiService){

    }

    post(question)
    {
        this.api.postQuestion(question)
    }

}