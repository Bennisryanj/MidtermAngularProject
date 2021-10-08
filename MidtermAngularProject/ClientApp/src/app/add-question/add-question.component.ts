import { Component, OnInit } from '@angular/core';
import { Question } from '../Models/Question';
import { QuestionService } from '../question.service';

@Component({
  selector: 'app-add-question',
  templateUrl: './add-question.component.html',
  styleUrls: ['./add-question.component.css']
})
export class AddQuestionComponent implements OnInit {

  constructor(private questionService: QuestionService) { }

  ngOnInit() {
  }

  addQuestion(questionId: string, questionText: string, answerText: string) {

    let question = new Question();
    question.questionId = questionId;
    question.questionText = questionText;
    question.answerText = answerText;




  }

}
