function X = dft2(x)
        C = size(x,2); %number of columns
        R = size(x,1); %number of rows
        nR = 0:1:R-1; %row vector for n
        kR = 0:1:R-1; %row vector for k
           nkR=nR'*kR;
        nC = 0:1:C-1; %row vector for n
        kC = 0:1:C-1; %row vector for k
           nkC=nC'*kC;
        y = zeros(size(x));
        y1 = y;
        for c = 1:C
            y(:,c) = dft_row(x(:,c),R,nkR);
        end
        for r = 1:R
            y1(r,:) =dft_col(y(r,:).',C,nkC);
        end
        X = y1;
end

function [Xk] = dft_col(xn,N,nk) 
       WN = exp(i*2*pi/N); %Twiddle factor (w)
       WNnk = WN .^ nk; %DFT matrix
       Xk = (1/N)*WNnk*xn; 
end  
 function [Xk] = dft_row(xn,N,nk) 
       WN = exp(i*2*pi/N); %Twiddle factor (w)
       WNnk = WN .^ nk; %DFT matrix
       Xk = (1/N)*WNnk*xn; 
 end  

% function out = idft2(x)
%         y = zeros(size(x));
%         y1 = y;
%         C = size(x,2); %number of columns
%         for c = 1:C
%             y(:,c) = idft(x(:,c));
%         end
%         R = size(x,1); %number of rows
%         for r = 1:R
%             y1(r,:) = idft(y(r,:).');
%         end
%         out = y1;
% end