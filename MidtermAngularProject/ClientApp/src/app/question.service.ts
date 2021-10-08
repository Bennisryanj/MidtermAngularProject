import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Question } from './Models/Question';

@Injectable({
  providedIn: 'root'
})
export class QuestionService {
  apiUrl: string = "http://localhost:46877/api/Questions";
  constructor(private httpClient: HttpClient) { }

  //need a get questions
  getQuestion(): Observable<Question[]> {
    return this.httpClient.get<Question[]>(this.apiUrl);
  }



  postQuestion(question: Question): Observable<Question> {
    return this.httpClient.post<Question>(this.apiUrl, question);

  }

  
}
