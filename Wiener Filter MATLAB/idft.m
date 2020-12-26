function [xn] = idft(Xk)
% The inverse DFT  is given by
%                    N-1
%      x(n) = (1/N) sum  X(k)*exp(i*2*pi*k*n/N), 0 <= n <= N-1.
%                   k=0      
       Xk=Xk(:); %make sure xk is a column vector
       N = length(Xk);
       n = 0:1:N-1; %row vector for n
       k = 0:1:N-1; %row vector for k
       WN = exp(i*2*pi/N); %Twiddle factor (w)
       nk = n'*k; %creates a N by N matrix of nk values
       WNnk = WN .^nk; %DFT matrix
       xn = (1/N)*WNnk*Xk;
 end